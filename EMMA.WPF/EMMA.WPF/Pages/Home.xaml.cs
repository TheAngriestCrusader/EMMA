using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EMMA.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            GenerateModuleTabs();
        }

        private void GenerateModuleTabs()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string moduleCetegoryRoot = "EMMA.Pages.Modules.";
            var pageTypes = assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Page))
                    && t.Namespace != null
                    && t.Namespace.StartsWith(moduleCetegoryRoot))
                .ToList();
            var moduleCategories = pageTypes.GroupBy(t => t.Namespace!
                .Substring(moduleCetegoryRoot.Length)
                .Split('.')[0]);

            foreach (var moduleCategory in moduleCategories)
            {
                string moduleCategoryName = moduleCategory.Key;
                TabItem tabItem = new()
                {
                    Header = moduleCategoryName,
                    Content = new Label()
                    {
                        Content = $"This is the {moduleCategoryName} moduleCategory.",
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    }
                };
                ModuleCategoryTabControl.Items.Add(tabItem);
            }
        }
    }
}
