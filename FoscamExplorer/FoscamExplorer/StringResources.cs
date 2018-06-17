//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// --------------------------------------------------------------------------------------------------
// <auto-generatedInfo>
// 	This code was generated by ResW File Code Generator (http://reswcodegen.codeplex.com)
// 	ResW File Code Generator was written by Christian Resma Helle
// 	and is under GNU General Public License version 2 (GPLv2)
// 
// 	This code contains a helper class exposing property representations
// 	of the string resources defined in the specified .ResW file
// 
// 	Generated: 04/23/2014 00:21:56
// </auto-generatedInfo>
// --------------------------------------------------------------------------------------------------
namespace FoscamExplorer
{
    using Windows.ApplicationModel.Resources;
    
    
    public partial class StringResources
    {
        
        private static ResourceLoader resourceLoader;
        
        static StringResources()
        {
            string executingAssemblyName;
            executingAssemblyName = Windows.UI.Xaml.Application.Current.GetType().AssemblyQualifiedName;
            string[] executingAssemblySplit;
            executingAssemblySplit = executingAssemblyName.Split(',');
            executingAssemblyName = executingAssemblySplit[1];
            string currentAssemblyName;
            currentAssemblyName = typeof(StringResources).AssemblyQualifiedName;
            string[] currentAssemblySplit;
            currentAssemblySplit = currentAssemblyName.Split(',');
            currentAssemblyName = currentAssemblySplit[1];
            if (executingAssemblyName.Equals(currentAssemblyName))
            {
                resourceLoader = new ResourceLoader("StringResources");
            }
            else
            {
                resourceLoader = new ResourceLoader(currentAssemblyName + "/StringResources");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Camera Account"
        /// </summary>
        public static string LogonPromptCameraAccount
        {
            get
            {
                return resourceLoader.GetString("LogonPromptCameraAccount");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Update Camera"
        /// </summary>
        public static string LogonUpdateCameraButton
        {
            get
            {
                return resourceLoader.GetString("LogonUpdateCameraButton");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Update all cameras"
        /// </summary>
        public static string LogonUpdateCameraCheckbox
        {
            get
            {
                return resourceLoader.GetString("LogonUpdateCameraCheckbox");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Not finding your Foscam camera from this computer.  Please make sure this computer is connected to the same network and please also ensure your cameras are turned on.  If that doesn't work then try using an ethernet cable to connect  your cameras."
        /// </summary>
        public static string NoCameraMessage
        {
            get
            {
                return resourceLoader.GetString("NoCameraMessage");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Camera not found"
        /// </summary>
        public static string NoCameraName
        {
            get
            {
                return resourceLoader.GetString("NoCameraName");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Searching..."
        /// </summary>
        public static string SearchingPrompt
        {
            get
            {
                return resourceLoader.GetString("SearchingPrompt");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "updated"
        /// </summary>
        public static string UpdatedMessage
        {
            get
            {
                return resourceLoader.GetString("UpdatedMessage");
            }
        }
    }
}
