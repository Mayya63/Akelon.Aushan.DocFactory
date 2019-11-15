using System;
using System.Collections.Generic;
using System.Reflection;

namespace Akelon.Auchan.DocFactory.TemplateModels
{
    public class BaseEntity
    {
        /// <summary>
        /// Преобразовать список свойств в модели словарь, для генерации текстового документа
        /// </summary>        
        /// <returns>Словарь ключ-значение</returns>
        public virtual Dictionary<string, string> GetDictionaryProperties()
        {
            var dict = new Dictionary<string, string>();
            var properties = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (var prop in properties)
                dict.Add(prop.Name, Convert.ToString(prop.GetValue(this)) ?? null);
            return dict;
        }
    }
}
