using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public class KnownTypesBinder : ISerializationBinder
    {
        public IList<Type> KnownTypes { get; set; }

        public Type BindToType(string assemblyName, string typeName)
        {
            return KnownTypes.SingleOrDefault(t => t.Name == typeName);
        }

        public void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            if (KnownTypes.Contains(serializedType))
            {
                assemblyName = null;
                typeName = serializedType.Name;
            }
            else
            {
                assemblyName = null;
                typeName = null;
            }
        }
    }
}
