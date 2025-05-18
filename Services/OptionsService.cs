using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekt.Dto;

namespace projekt.Services
{
    class OptionsService<T>
    {
        private List<T> options = new();

        public void addOptions(List<T> list)
        {
            foreach (var item in list)
            {
                if (!options.Contains(item))
                    options.Add(item);
            }
        }

        public List<T> getOptions()
        {
            return this.options;
        }
    }
}
