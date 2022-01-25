using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using POCSnowflakeIndexServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer.Helpers
{
    public  class JSONConverterHelper : IJSONConverterService
    {
        public string SerializeObject(object obj)
        {
            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new NullToEmptyListResolver();
            settings.Formatting = Formatting.Indented;
            settings.ObjectCreationHandling = ObjectCreationHandling.Replace;
            return JsonConvert.SerializeObject(obj, settings);
        }
    }

    //ref: https://newbedev.com/how-to-default-a-null-json-property-to-an-empty-array-during-serialization-with-a-list-t-property-in-json-net
    internal class NullToEmptyListResolver : DefaultContractResolver
    {
        protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
        {
            IValueProvider provider = base.CreateMemberValueProvider(member);

            if (member.MemberType == MemberTypes.Property)
            {
                Type propType = ((PropertyInfo)member).PropertyType;
                if (propType.IsGenericType &&
                    propType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    return new EmptyListValueProvider(provider, propType);
                }
            }

            return provider;
        }
    }

    internal class EmptyListValueProvider : IValueProvider
    {
        private IValueProvider innerProvider;
        private object defaultValue;

        public EmptyListValueProvider(IValueProvider innerProvider, Type listType)
        {
            this.innerProvider = innerProvider;
            defaultValue = Activator.CreateInstance(listType);
        }

        public void SetValue(object target, object value)
        {
            innerProvider.SetValue(target, value ?? defaultValue);
        }

        public object GetValue(object target)
        {
            return innerProvider.GetValue(target) ?? defaultValue;
        }
    }
}
