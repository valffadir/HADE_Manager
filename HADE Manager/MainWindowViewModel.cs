using HADE_Manager;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using System.Windows.Controls;

namespace HADE_Manager
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            MenuItems = new[]
            {

                new MenuItem("Home", "Home", new Home())
                {
                    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                },
                new MenuItem("Rodines","Verified", new Rondines())
                {
                    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                },
                new MenuItem("Solicitudes de Soporte","EmailOutline", new Rondines())
                {
                    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                },
                new MenuItem("Ordenes de Servicio","Wrench", new Cambios())
                {
                    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                },
                new MenuItem("Stock","PackageVariantClosed", new Cambios())
                {
                    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                },
                new MenuItem("Verificaciones Pendientes","CheckboxMultipleMarkedOutline", new Cambios())
                {
                    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                },
                new MenuItem("Usuarios","AccountMultiple", new Usuarios()
                ){
                    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                },

                //new MenuItem("Palette", new PaletteSelector { DataContext = new PaletteSelectorViewModel() } 
                //    ),
                //new MenuItem("Buttons & Toggles", new Buttons())
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //    },
                //new MenuItem("Fields", new TextFields())
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //    },
                //new MenuItem("Pickers", new Pickers { DataContext = new PickersViewModel()}
                //    ),
                //new MenuItem("Sliders", new Sliders()
                //    ),
                //new MenuItem("Chips", new Chips()
                //    ),
                //new MenuItem("Typography", new Typography())
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto,
                //        HorizontalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //    },
                //new MenuItem("Cards", new Cards())
                //{
                //    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //},
                //new MenuItem("Icon Pack", new IconPack { DataContext = new IconPackViewModel() }
                //    ),
                //new MenuItem("Colour Zones", new ColorZones()
                //    ),
                //new MenuItem("Lists", new Lists { DataContext = new ListsAndGridsViewModel()})
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto   
                //    },  
            };
        }

        public MenuItem[] MenuItems { get; }
    }
}
