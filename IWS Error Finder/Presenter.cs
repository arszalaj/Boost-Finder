using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoostFinder
{
    public class Presenter
    {
        Model model;
        public Presenter()
        {
            model = new Model();
        }
        public string getFile(string url, string key, string soundPath)
        {
            return model.getFile(url, key, soundPath);
        }
    }
}
