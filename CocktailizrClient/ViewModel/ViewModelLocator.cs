/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:CocktailizrClient"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System.ServiceModel.Security;
using CocktailizrClient.CocktailServiceReference;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using CocktailizrClient.AdminServiceReference;

namespace CocktailizrClient.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            Cleanup();

            // CocktailService - Client
            SimpleIoc.Default.Register(() =>
            {
                var client = new CocktailServiceClient();
                client.ClientCredentials.UserName.UserName = "Admin";
                client.ClientCredentials.UserName.Password = "Cocktailizor";
                return client;
            });

            // AdminService - Client
            SimpleIoc.Default.Register(() =>
            {
                var client = new AdminServiceClient();
                client.ClientCredentials.UserName.UserName = "Admin";
                client.ClientCredentials.UserName.Password = "Cocktailizor";
                return client;
            });

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CocktailViewModel>();
            SimpleIoc.Default.Register<SearchViewModel>();
            SimpleIoc.Default.Register<ExtendedSearchViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public CocktailViewModel Cocktail
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CocktailViewModel>();
            }
        }

        public SearchViewModel Search
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SearchViewModel>();
            }
        }

        public ExtendedSearchViewModel ExtendedSearch
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ExtendedSearchViewModel>();
            }
        }

        public static void Cleanup()
        {
            SimpleIoc.Default.Reset();
        }
    }
}