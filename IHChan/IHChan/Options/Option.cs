using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Options
{
    internal class Option
    {
        #region Fields
        /// <summary>
        /// Config File Path
        /// </summary>
        private readonly string ConfigFilePath = @"Options/Options.yaml";

        /// <summary>
        /// Option Key
        /// </summary>
        private Key _apikey;

        /// <summary>
        /// Option MetroStyle
        /// </summary>
        private MetroStyle _metroStyle;
        #endregion

        #region Properties
        /// <summary>
        /// Key of Covid API in the data.co.kr
        /// </summary>
        internal string APIKey => _apikey.API_KEY;

        /// <summary>
        /// MetroForm ThemeStyle value
        /// </summary>
        internal string ThemeStyle => _metroStyle.MetroThemeStyle;

        /// <summary>
        /// MetroForm ColorStyle value
        /// </summary>
        internal string ColorStyle => _metroStyle.MetroColorStyle;

        /// <summary>
        /// Singleton Instance
        /// </summary>
        internal static Option Instance { get; }
        #endregion

        #region Constructor
        /// <summary>
        /// constructor
        /// </summary>
        protected Option()
        {
            _apikey = YamlController.DeserializerAsTag<Key>(ConfigFilePath, nameof(Key));
            _metroStyle = YamlController.DeserializerAsTag<MetroStyle>(ConfigFilePath, nameof(MetroStyle));
        }

        /// <summary>
        /// Static constructor
        /// </summary>
        static Option()
        {
            Instance = new Option();            
        }
        #endregion

        #region Methods
        /// <summary>
        /// String To Enum Value
        /// </summary>
        /// <typeparam name="T">Enum Type</typeparam>
        /// <param name="value">string value</param>
        /// <returns>Enum value</returns>
        internal T GetStringToEnumValue<T>(string value)
        {
            var obj = Enum.Parse(typeof(T), value);

            if (obj is null)
                return default(T);

            return (T)obj;
        }
        #endregion
    }

    #region Setting Class
    internal class Key
    {
        internal string API_KEY { get; set; }        
    } 

    internal class MetroStyle
    {
        internal string MetroThemeStyle { get; set; }

        internal string MetroColorStyle { get; set; }
    }
    #endregion
}
