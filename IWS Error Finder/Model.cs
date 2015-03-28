using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;

namespace BoostFinder
{
    class Model
    {
        private bool isBuildSuccessful = false;
        private int index;
        private string repositoryUrl;
        private string ClientLogsUrl;
        private string ServerLogsUrl;
        private string[] lines;
        public List<string> listOfKeys;
        public List<string> alreadyFoundEntries = new List<string>();
        private string soundPath;
        public int[] keyCounter;

        public Model()
        {

        }

        public string getFile(string url, List<string> listOfKeys, string soundPath)
        {
            this.listOfKeys = listOfKeys;
            this.soundPath = soundPath;
            var errorContent = "";
            keyCounter = new int[4];
            try
            {
                findWords(url);
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

        public void findWords(string url)
        {
            System.Net.WebClient webclient = new System.Net.WebClient();
            webclient.Credentials = new System.Net.NetworkCredential("arszalaj","haslo1haslo");

            var contents = webclient.DownloadString(url);

            //WebRequest req = HttpWebRequest.Create(url);
            //req.Method = "GET";

            //string source;
            //using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
            //{
            //    source = reader.ReadToEnd();
            //}

            lines = contents.Replace("\r", "").Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (!AnyContainsAny(alreadyFoundEntries, line) && ContainsAny(line, listOfKeys))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);
                    //System.Media.SoundPlayer player = new System.Media.SoundPlayer("http://www.tailspintoys.com/sounds/stop.wav");
                    player.Play();
                    alreadyFoundEntries.Add(line);
                }
            }

        }

        public bool ContainsAny(string value, List<string> keys)
        {
            foreach (string key in keys)
            {
                if (!string.IsNullOrEmpty(key))
                {
                    if (value.ToLower().Contains(key.ToLower()))
                    {
                        keyCounter[keys.IndexOf(key)]++;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool AnyContainsAny(List<string> alreadyFoundEntries, string line)
        {
            foreach (string entry in alreadyFoundEntries)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        if (entry.ToLower().Equals(line.ToLower()))
                        {
                            //keyCounter[listOfKeys.IndexOf(entry)]--;
                            return true;
                        }
                    }
                }

            return false;
        }

    }
}
