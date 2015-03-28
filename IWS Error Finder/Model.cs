using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;

namespace IwsErrorFinder
{
    class Model
    {
        private bool isBuildSuccessful = false;
        private int index;
        private string repositoryUrl;
        private string ClientLogsUrl;
        private string ServerLogsUrl;
        private string[] lines;
        private string key;
        private string soundPath;

        public Model()
        {

        }

        public string getFile(string url, string key, string soundPath)
        {
            this.key = key;
            this.soundPath = soundPath;
            var errorContent = "";
            try
            {
                if (!String.IsNullOrEmpty(url))
                {
                    errorContent += "Client side: " + Environment.NewLine + Environment.NewLine + getClientErrors(url) + Environment.NewLine;
                }
                else
                {
                    errorContent = "Please enter a URL";
                }
            }
            catch (WebException ex)
            {
                errorContent = "Wrong URL";
            }
            catch (ArgumentException ex)
            {
                errorContent = "Wrong URL";
            }
            catch (UriFormatException ex)
            {
                errorContent = "Wrong URL";
            }

            return errorContent;
        }

        public string getHttpParam(string url, string param)
        {
            string result = "";
            Uri myUri = new Uri(url);
            result = HttpUtility.ParseQueryString(myUri.Query).Get(param);

            return result;
        }

        public String getClientErrors(string url)
        {
            System.Net.WebClient webclient = new System.Net.WebClient();
            webclient.Credentials = new System.Net.NetworkCredential("arszalaj","haslo1haslo");

            var contents = webclient.DownloadString(url);

            WebRequest req = HttpWebRequest.Create(url);
            req.Method = "GET";

            string source;
            using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                source = reader.ReadToEnd();
            }

            lines = contents.Replace("\r", "").Split('\n');

            string result = "", IwsErrors = "", GeneErrors ="";
            int IwsErrorCounter = 0, GeneErrorCounter = 0;
            isBuildSuccessful = false;
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (line.Contains(key))
                {


                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);
                    //System.Media.SoundPlayer player = new System.Media.SoundPlayer("http://www.tailspintoys.com/sounds/stop.wav");
                    player.Play();
                }
            }
            result = " IWS errors: " + IwsErrorCounter.ToString() + Environment.NewLine + IwsErrors + Environment.NewLine +
                        " Gene errors: " + GeneErrorCounter.ToString() + Environment.NewLine + GeneErrors + Environment.NewLine;
            
            return result;
        }

    }
}
