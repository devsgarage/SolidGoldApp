using SolidGoldApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SolidGoldApp.Factories
{
    public class PasswordRuleFactory
    {
        private List<IPasswordRule> rules;
        public static PasswordRuleFactory Instance { get; } = new PasswordRuleFactory();
        private PasswordRuleFactory()
        {
            LoadRules();
        }

        public List<IPasswordRule> GetRules() => rules;

        private void LoadRules()
        {
            rules = new List<IPasswordRule>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();    
            var it = typeof(IPasswordRule);
            foreach (var asm in assemblies)
            {
                var types = asm.GetLoadableTypes().Where(x => it.IsAssignableFrom(x) 
                && !x.IsInterface
                && !x.IsAbstract
                ).ToList();
                foreach (var t in types)
                {
                    rules.Add((IPasswordRule)Activator.CreateInstance(t));
                }
            }
        }
    }

    public static class TypeLoaderExtensions
    {
        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException("assembly");
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }
    }
}
