using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Utilities_CSharp
{
    public class ResourceHelper
    {
        private ResourceManager ResourceManager { get; set; }
        public ResourceHelper(string resourceName, Assembly assembly)
        {
            ResourceManager = new ResourceManager(resourceName, assembly);
        }

        public string GetResourceValueByKey(string key)
        {
            DictionaryEntry entry =
                ResourceManager.GetResourceSet(Thread.CurrentThread.CurrentCulture, true, true)
                    .OfType<DictionaryEntry>()
                    .FirstOrDefault(dctEntry => dctEntry.Value.ToString() == key);
            return entry.Value.ToString();
        }

        public string GetResourceKeyByValue(string value)
        {
            DictionaryEntry entry = ResourceManager.GetResourceSet(Thread.CurrentThread.CurrentCulture, true, true)
                    .OfType<DictionaryEntry>()
                    .FirstOrDefault(dctEntry => dctEntry.Value.ToString() == value);
            return entry.Key.ToString();
        }
    }
}
