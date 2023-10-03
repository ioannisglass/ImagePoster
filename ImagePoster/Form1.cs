using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ImagePoster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog w_dlgFileOpen = new OpenFileDialog();
            w_dlgFileOpen.Title = "Select image file.";
            w_dlgFileOpen.Filter = "PNG file | *.png";

            if (w_dlgFileOpen.ShowDialog() == DialogResult.OK)
            {
                string w_strImagePath = w_dlgFileOpen.FileName;
                txtImagePath.Text = w_strImagePath;
                picImage.ImageLocation = w_strImagePath;
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            string w_strFileToPost = txtImagePath.Text.Trim();
            if (!File.Exists(w_strFileToPost))
            {
                MessageBox.Show("File not exist.");
                return;
            }
            string w_strOutDir = txtOutDir.Text.Trim();
            if (string.IsNullOrEmpty(w_strOutDir) || !Directory.Exists(w_strOutDir))
            {
                MessageBox.Show("Out directory failed.");
                return;
            }
            rtxtResponse.Text = string.Empty;
            object w_objResponse = await PostFileAndStringsAsync(w_strFileToPost, chkbTransparent.Checked, chkbWhiteBack.Checked, chkbPassport.Checked, chkbVisualize.Checked);
            try
            {
                MResponse w_mResponse = JsonConvert.DeserializeObject<MResponse>((string)w_objResponse);
                string w_strResponse = JsonConvert.SerializeObject(w_mResponse, Newtonsoft.Json.Formatting.Indented);

                string w_strImgName = Path.GetFileNameWithoutExtension(w_strFileToPost);
                w_strImgName = w_strImgName + ".png";
                if (chkbTransparent.Checked && w_mResponse.transparent)
                {
                    string w_strTransUrl = $"{Program.g_strAPI}/download?n={w_strImgName}&t=transparent";
                    string w_strTransOutPath = Path.Combine(w_strOutDir, "transparent");
                    if (!Directory.Exists(w_strTransOutPath))
                        Directory.CreateDirectory(w_strTransOutPath);
                    w_strTransOutPath = Path.Combine(w_strTransOutPath, w_strImgName);
                    await downloadFile(w_strTransUrl, w_strTransOutPath);
                }

                if (chkbWhiteBack.Checked && w_mResponse.white_background)
                {
                    string w_strWhiteUrl = $"{Program.g_strAPI}/download?n={w_strImgName}&t=white_background";
                    string w_strWhiteOutPath = Path.Combine(w_strOutDir, "white_background");
                    if (!Directory.Exists(w_strWhiteOutPath))
                        Directory.CreateDirectory(w_strWhiteOutPath);
                    w_strWhiteOutPath = Path.Combine(w_strWhiteOutPath, w_strImgName);
                    await downloadFile(w_strWhiteUrl, w_strWhiteOutPath);
                }

                if (chkbPassport.Checked && w_mResponse.passport)
                {
                    string w_strPassUrl = $"{Program.g_strAPI}/download?n={w_strImgName}&t=passport";
                    string w_strPassOutPath = Path.Combine(w_strOutDir, "passport");
                    if (!Directory.Exists(w_strPassOutPath))
                        Directory.CreateDirectory(w_strPassOutPath);
                    w_strPassOutPath = Path.Combine(w_strPassOutPath, w_strImgName);
                    await downloadFile(w_strPassUrl, w_strPassOutPath);
                }
                rtxtResponse.Text = w_strResponse;
            }
            catch (Exception ex)
            {
                rtxtResponse.Text = (string)w_objResponse;
            }
        }

        static async Task<object> PostFileAndStringsAsync(string _strFileToPost, bool _bTransparent, bool _bWhite_background, bool _bPassport, bool _bVisualize)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                using (MultipartFormDataContent form = new MultipartFormDataContent())
                {
                    // Add string content
                    form.Add(new StringContent(_bTransparent.ToString()), "transparent");
                    form.Add(new StringContent(_bWhite_background.ToString()), "white_background");
                    form.Add(new StringContent(_bPassport.ToString()), "passport");
                    form.Add(new StringContent(_bVisualize.ToString()), "visualize");

                    using (FileStream fileStream = new FileStream(_strFileToPost, FileMode.Open, FileAccess.Read))
                    {
                        // Add the file content to the request
                        form.Add(new StreamContent(fileStream), "file", Path.GetFileName(_strFileToPost));

                        // Send the POST request with the file and strings
                        HttpResponseMessage response = await httpClient.PostAsync($"{Program.g_strAPI}/api/image", form);
                        string w_strRet = await response.Content.ReadAsStringAsync();
                        // Check if the request was successful
                        // if (response.IsSuccessStatusCode)
                        // {
                        //     Console.WriteLine("File and strings uploaded successfully.");
                        // }
                        // else
                        // {
                        //     Console.WriteLine("File and strings upload failed. Status code: " + response.StatusCode);
                        // }
                        return w_strRet;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string PostFormData(string imgString, bool transparent, bool whiteBackground, bool passport, bool visualize)
        {
            try
            {
                string url = Program.g_strAPI;
                string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "multipart/form-data; boundary=" + boundary;
                request.Method = "POST";
                request.KeepAlive = true;

                Stream requestStream = request.GetRequestStream();
                StreamWriter writer = new StreamWriter(requestStream, Encoding.UTF8);

                // Add the string parameters
                writer.Write("--" + boundary + "\r\n");
                writer.Write("Content-Disposition: form-data; name=\"transparent\"\r\n\r\n");
                writer.Write(transparent.ToString() + "\r\n");

                writer.Write("--" + boundary + "\r\n");
                writer.Write("Content-Disposition: form-data; name=\"white_background\"\r\n\r\n");
                writer.Write(whiteBackground.ToString() + "\r\n");

                writer.Write("--" + boundary + "\r\n");
                writer.Write("Content-Disposition: form-data; name=\"passport\"\r\n\r\n");
                writer.Write(passport.ToString() + "\r\n");

                writer.Write("--" + boundary + "\r\n");
                writer.Write("Content-Disposition: form-data; name=\"visualize\"\r\n\r\n");
                writer.Write(visualize.ToString() + "\r\n");

                // Add the file content
                writer.Write("--" + boundary + "\r\n");
                writer.Write("Content-Disposition: form-data; name=\"file\"; filename=\"" + Path.GetFileName(imgString) + "\"\r\n");
                writer.Write("Content-Type: application/octet-stream\r\n\r\n");
                writer.Flush();

                using (FileStream fileStream = new FileStream(imgString, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        requestStream.Write(buffer, 0, bytesRead);
                    }
                    requestStream.Flush();
                }

                writer.Write("\r\n--" + boundary + "--\r\n");
                writer.Flush();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                string responseString = reader.ReadToEnd();

                reader.Close();
                responseStream.Close();
                response.Close();

                return responseString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }
        private static async Task downloadFile(string _strFileUrl, string _strOutPath)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(_strFileUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    using (Stream contentStream = await response.Content.ReadAsStreamAsync(),
                                  stream = new FileStream(_strOutPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        await contentStream.CopyToAsync(stream);
                    }
                    Console.WriteLine("Files downloaded successfully.");
                }
                else
                {
                    Console.WriteLine("Error downloading: " + response.ReasonPhrase);
                }
            }
        }
        public void DownloadFile(string fileUrl, string savePath)
        {
            try
            {
                // Create a web request to the file URL
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fileUrl);

                // Send the request and get the response
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Check if the response is OK (HTTP status code 200-299)
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Get the response stream
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        // Create a file stream to save the downloaded file
                        using (FileStream fileStream = new FileStream(savePath, FileMode.Create))
                        {
                            // Read the response stream and save it to the file stream
                            byte[] buffer = new byte[4096];
                            int bytesRead;
                            while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fileStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }

                    Console.WriteLine("File downloaded successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to download the file. HTTP status code: " + response.StatusCode);
                }

                // Close the response
                response.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
        private void btnSetDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(dialog.SelectedPath))
                    txtOutDir.Text = dialog.SelectedPath;
            }
        }
    }
}
