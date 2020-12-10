using Shop.UIForms.ViewModels;

namespace Shop.UIForms.Infraestructure
{
    class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
