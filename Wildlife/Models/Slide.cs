using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string  Large { get; set; }
        public string Small { get; set; }

        public Slide() { }
        public Slide(int id, string large, string small)
        {
            Id = id;
            Large = large;
            Small = small;
        }

        public List<Slide> GetList()
        {
            var items = new List<Slide>();
            int i = 1;
            bool bOk = true;

            var rm = Resources.Slider.ResourceManager;
            while (bOk)
            {
                try
                {
                    var name = rm.GetString("slide" + i + "Large");
                    if (name == null) bOk = false;
                    else
                    {
                        items.Add(new Slide(i, name
                            , rm.GetString("slide" + i + "Small"))
                            );
                    }
                    i++;
                }
                catch (Exception)
                {
                    bOk = false;
                }
            }
            return items;
        }


    }
}
