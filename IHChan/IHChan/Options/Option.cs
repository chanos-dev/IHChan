using IHChan.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace IHChan.Options
{
    public class Option
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
        internal string APIKey
        {
            get => _apikey.API_KEY;
            set
            {
                _apikey.API_KEY = value;
                Save();
            }
        }

        /// <summary>
        /// MetroForm ThemeStyle value
        /// </summary>
        internal string ThemeStyle
        {
            get => _metroStyle.MetroThemeStyle;
            set
            {
                _metroStyle.MetroThemeStyle = value;
                Save();
            }
        }

        /// <summary>
        /// MetroForm ColorStyle value
        /// </summary>
        internal string ColorStyle
        {
            get => _metroStyle.MetroColorStyle;
            set
            {
                _metroStyle.MetroColorStyle = value;
                Save();
            }
        }

        internal List<IRefresh> Forms { get; set; } = new List<IRefresh>();

        internal List<ISetting> UnitForms { get; set; } = new List<ISetting>();

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

        /// <summary>
        /// Save option instance values
        /// </summary>
        private void Save()
        {
            var value = new Dictionary<object, object>()
            {
                { "Key", _apikey.GetValues() },
                { "MetroStyle", _metroStyle.GetValues() },
            }; 

            YamlController.Serializer(ConfigFilePath, value); 

            // refresh form style after save.
            Forms.ForEach(form => form.StyleRefresh());
            UnitForms.ForEach(unit => unit.DirectSet());
        } 

        #endregion
    }

    #region Setting Class
    internal class Key
    {
        internal string API_KEY { get; set; }      
        
        public Dictionary<object, object> GetValues()
        {
            return new Dictionary<object, object>()
            {
                { "API_KEY", API_KEY },
            };
        }
    } 

    internal class MetroStyle
    {
        internal string MetroThemeStyle { get; set; }

        internal string MetroColorStyle { get; set; }

        public Dictionary<object, object> GetValues()
        {
            return new Dictionary<object, object>()
            {
                { "MetroThemeStyle", MetroThemeStyle },
                { "MetroColorStyle", MetroColorStyle },
            };
        }
    }
    #endregion
}
