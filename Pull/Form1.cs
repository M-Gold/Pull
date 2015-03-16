using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;

namespace Puull_2
{
    /// <summary>
    /// /////////////FAILED TO DOWNLOAD http://puu.sh/QBrK
    /// </summary>

    public partial class Form1 : Form
    {

        int numDownloaded = 0, filterMode, toDownloadFrom = 0, targetDownload;
        volatile bool threadsQuit = false;
        volatile int attempts;
        bool running = false, useFilter;
        Random rnd = new Random();
        string downloadPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                downloadPath = tbDownPath.Text;
                if (downloadPath == "")
                {
                    downloadPath = Environment.CurrentDirectory.ToString() + "\\Pull Downloads\\";
                }
                if (!createDownloadFolder(downloadPath))
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[1];
                    return;
                }
                ((Control)tabControl1.TabPages[1]).Enabled = false;
                ((Control)tabControl1.TabPages[2]).Enabled = false;
                cbImgur.Enabled = false;
                cbPuush.Enabled = false;
                cbTiny.Enabled = false;


                button1.Text = "Stop";
                targetDownload = Convert.ToInt32(textBox1.Text); //relies on them entering a number
                lbl_targetDownloads.Text = targetDownload.ToString();
                attempts = 0;

                panel2.Visible = true;



                toDownloadFrom = 0;
                if (cbImgur.Checked)
                    toDownloadFrom += 2;
                if (cbPuush.Checked)
                    toDownloadFrom += 4;

                running = true;
                threadsQuit = false;
                useFilter = cbFilter.Checked;
                if (useFilter)
                {
                    filterMode = rbDownload.Checked ? 1 : 0;       
                }

                Thread t = new Thread(new ThreadStart(startDownloads));
                t.IsBackground = true;
                t.Start();

                while (numDownloaded < targetDownload && !threadsQuit)
                {
                    Application.DoEvents();
                    Thread.Sleep(50);
                }

            }

                endDownload();
 

        }

        void endDownload()
        {
            button1.Text = "Start";
            threadsQuit = true;
            running = false;
            panel2.Visible = false;
            numDownloaded = 0;
            ((Control)tabControl1.TabPages[1]).Enabled = true;
            ((Control)tabControl1.TabPages[2]).Enabled = true;
            cbImgur.Enabled = true;
           // cbPuush.Enabled = true;
           // cbTiny.Enabled = true;
        }

        void startDownloads()
        {
            ThreadInfo threadInfo = new ThreadInfo();
            while (!threadsQuit)
            {
                if(cbImgur.Checked)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(downloadImgur), threadInfo);
                    attempts++;
                    Thread.Sleep(100);
                }

                if(cbPuush.Checked)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(downloadPuush), threadInfo);
                    attempts++;
                    Thread.Sleep(100);
                }
     
                if(cbTiny.Checked)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(downloadTinypic), threadInfo);
                    attempts++;
                    Thread.Sleep(100);
                }
            }



        }

        void downloadTinypic(object junk)
        {
            Thread.CurrentThread.IsBackground = true;
            string extension = null;
            string URL = null;

            useFilter = cbFilter.Checked; //////TEMP
            downloadPath = tbDownPath.Text;
            if (downloadPath == "")
            {
                downloadPath = Environment.CurrentDirectory.ToString() + "\\Pull Downloads\\";
            }   ////ALL TEMP



            WebClient wc = new WebClient();

            do
            {
                string source = wc.DownloadString("http://tinypic.com/random.php?type=images");
                //File.WriteAllText(Directory.GetCurrentDirectory().ToString() + " \\source.txt", source);
                Regex r = new Regex(Regex.Escape("http://tinypic.com/view.php?pic=") + "(.*?)" + Regex.Escape("&"));
                Match mc = r.Match(source);
                URL = mc.ToString();

                source = wc.DownloadString(URL + "s=8");
                //File.WriteAllText(Directory.GetCurrentDirectory().ToString() + " \\source2.txt", source);
                r = new Regex(Regex.Escape("<br/><a href=\"") + "(.*?)" + Regex.Escape("\""));
                mc = r.Match(source);
                URL = mc.ToString();
                //File.WriteAllText(Directory.GetCurrentDirectory().ToString() + " \\source3.txt", URL);

                URL = URL.Replace("<br/><a href=\"", string.Empty).TrimEnd('"');


                WebRequest request = WebRequest.Create(URL);
                WebResponse response = request.GetResponse();
                extension = "." + response.Headers["Content-Type"].Split('/')[1];
                request.Abort();
                response.Close();
                if (extension == ".jpeg")
                    extension = ".jpg";

                if (useFilter)
                {
                    extension = filterExtension(extension);
                }

            } while (extension == ".error");

            string name = URL.Split('/')[3].Split('.')[0];

            if (shouldQuit())
                return;

            numDownloaded++;
            this.Invoke((MethodInvoker)delegate { lbl_currentDownloads.Text = numDownloaded.ToString(); });

            MessageBox.Show(downloadPath);
            if (checkBox1.Checked)
            {
                Directory.CreateDirectory(downloadPath + "\\Tinypic");
                wc.DownloadFile(URL, downloadPath + "\\Tinypic\\" + name + extension);
            }
            else
            {
                wc.DownloadFile(URL, downloadPath + "\\" + name + extension);
            }



        }

        public void downloadImgur(object junk)
        {
            string url = null; 
            bool goodURL = false;
            WebClient wc = new WebClient();
            string extension = null;
            while (!goodURL)
            {
                url = generateRandomString(5, 7);
                WebRequest req = HttpWebRequest.Create("http://www.imgur.com/" + url);
 
                try
                {
                    using (WebResponse rep = req.GetResponse())
                        goodURL = true;

                    extension = wc.DownloadString("https://api.imgur.com/oembed.json?url=http://i.imgur.com/" + url);
                    File.WriteAllText(url + ".txt", extension);

 
                    Regex r = new Regex(Regex.Escape(url + ".") + "(.*)" + Regex.Escape("\"}"));

                    extension = r.Match(extension).Value.Split('.')[1];
                    extension = extension.Remove(extension.IndexOf('"'));
                    extension = extension.Remove(extension.IndexOf('\\'));


                    if (useFilter)
                    {
                        if (filterExtension("." + extension) == ".error")
                            goodURL = false;
                    }

                }
                catch { }

                if (shouldQuit())
                    return;

            }
           
          //  MessageBox.Show(extension);

            numDownloaded++;
            this.Invoke((MethodInvoker)delegate { lbl_currentDownloads.Text = numDownloaded.ToString(); });

            try
            {


                if (checkBox1.Checked)
                {
                    Directory.CreateDirectory(downloadPath + "\\Imgur");
                    wc.DownloadFile("http://www.imgur.com/" + url + "." + extension, downloadPath + "\\Imgur\\" + url + "." + extension);
                }
                else
                {
                    wc.DownloadFile("http://www.imgur.com/" + url + "." + extension, downloadPath + "\\" + url + "." + extension);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message + " |URL: " + url + "|FULL: " + "http://www.imgur.com/" + url + "." + extension );
            }
            



            if (numDownloaded >= targetDownload)
            {
                threadsQuit = true;
            }



        }

        public void downloadPuush(object junk)
        {

            string url, extension;
            do
            {
                if (shouldQuit())
                    return;

                url = findPuushUrlWithContent();                         //1. Get a URL that has a file
                extension = getExtension(url);                         //2. What is its extention?

                if (shouldQuit())
                    return;

                if (useFilter)
                {
                    extension = filterExtension(extension);
                }

            } while (extension == ".error");

            try
            {


                numDownloaded++;
                this.Invoke((MethodInvoker)delegate { lbl_currentDownloads.Text = numDownloaded.ToString(); });

                WebClient webClient = new WebClient();
                if (checkBox1.Checked)
                {
                    Directory.CreateDirectory(downloadPath + "\\Puush");
                    webClient.DownloadFile("http://puu.sh/" + url + "/", downloadPath + "\\Puush\\" + url + extension);
                }
                else                                                                                                       //3. Download it.
                {
                    webClient.DownloadFile("http://puu.sh/" + url + "/", downloadPath + "\\" + url + extension);
                }

                           
                if (numDownloaded >= targetDownload)
                {
                    threadsQuit = true;
                }
            }
            catch
            {

            }

        }

        string generateRandomString(int min, int max)
        {

            int numOfChars, i;
            string theString = "";

            char[] charPool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();


            numOfChars = rnd.Next(min, max + 1); //a random lengthed string (typically 4-5 for puush. 6 exists but are mostly empty)
            for (i = 0; i < numOfChars; i++)
            {
                theString = theString + charPool[rnd.Next(0, 62)]; //Add on a new random char from the char pool for each length of our random string
            }
            return theString; //return the string
        }

        bool puushUrlHasContent(string randomString)
        {
            try
            {
                WebRequest req2 = HttpWebRequest.Create("http://puu.sh/" + randomString);
                using (WebResponse resp = req2.GetResponse())            //Just send a request to the URL. If it doesn't throw an exception, we can assume there's a file there
                    return true;
            }
            catch
            {
                return false; //If it throws an exception, we can assume that there's no file there
            }


        }

        string findPuushUrlWithContent()
        {
            string theString;

            do
            {
                theString = generateRandomString(4, 6); //Loop through random strings until we find one holding a file
            } while (!puushUrlHasContent(theString));

            return theString;
        }

        string getExtension(string randomString)
        {
            WebRequest request = WebRequest.Create("http://puu.sh/" + randomString);
            WebResponse response = request.GetResponse(); // could use a try catch
            string s = response.Headers["Content-Disposition"];
            // Stream streamWithFileBody = response.GetResponseStream();
            string ext;

            if (s != null)
            {
                ext = s.Substring(s.LastIndexOf(".")).TrimEnd('"');
            }
            else
            {
                ext = ".error";
            }
            response.Close();
            request.Abort();

            return ext;
        }

        string filterExtension(string extension)
        {

            switch (filterMode)
            {

                case 0:
                    foreach (DataGridViewRow r in filterGrid.Rows)
                    {
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if (c.Value != null)
                            {
                                MessageBox.Show("Does |" + c.Value + "| == |." + extension + "|");
                                if (extension == "." + c.Value.ToString())
                                {
                                    return ".error";
                                }
                            }
                        }
                    }
                    return extension;


                case 1:
                    foreach (DataGridViewRow r in filterGrid.Rows)
                    {
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if (c.Value != null)
                            {
                                if (extension == "." + c.Value.ToString())
                                {
                                    return extension;
                                }
                            }
                        }
                    }
                    return ".error";

            }
            return "";


        }
        bool shouldQuit()
        {
            return threadsQuit;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rbExclude.Enabled = !rbExclude.Enabled;
            rbDownload.Enabled = !rbDownload.Enabled;
            label4.Enabled = !label4.Enabled;
            toggleGridView(filterGrid);

        }

        private void filterGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (filterGrid.CurrentRow.Index != filterGrid.Rows.Count - 1)
                {
                    filterGrid.Rows.RemoveAt(filterGrid.CurrentRow.Index);
                }
            }

        }

        private void filterGrid_MouseLeave(object sender, EventArgs e)
        {
            if (filterGrid.CurrentRow != null)
            {
                filterGrid.CurrentRow.Selected = false;
            }


            foreach (DataGridViewRow r in filterGrid.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value == null)
                        return;

                    if (c.Value.ToString().Contains("."))
                    {
                        c.Value = c.Value.ToString().Replace(".", string.Empty);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            threadsQuit = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Environment.CurrentDirectory.ToString();

            fbd.ShowDialog();

            if (fbd.SelectedPath != "" && fbd.SelectedPath != Environment.CurrentDirectory.ToString())
                tbDownPath.Text = fbd.SelectedPath;
            fbd.Dispose();
        }

        bool createDownloadFolder(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            downloadPath = tbDownPath.Text;
            if (downloadPath == "")
            {
                downloadPath = Environment.CurrentDirectory.ToString() + "\\Pull Downloads\\";
            }
            if(!Directory.Exists(downloadPath))
            {
                Directory.CreateDirectory(downloadPath);
            }
            
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = Environment.GetEnvironmentVariable("WINDIR") +@"\explorer.exe";
                prc.StartInfo.Arguments = downloadPath;
                prc.Start();
            
        }

        void toggleGridView(DataGridView theGrid)
        {
            Color theColour = theGrid.ReadOnly ? Color.White : System.Drawing.SystemColors.Control;

            theGrid.ColumnHeadersDefaultCellStyle.BackColor = theGrid.ReadOnly ? System.Drawing.SystemColors.Control : Color.LightGray;
            theGrid.ReadOnly = !theGrid.ReadOnly; 
            foreach (DataGridViewRow row in theGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = theColour;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toggleGridView(filterGrid);
        }

        private void cbSites_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = (cbImgur.Checked || cbPuush.Checked || cbTiny.Checked);
        }

    }



    class ThreadInfo
    {
    }
}
