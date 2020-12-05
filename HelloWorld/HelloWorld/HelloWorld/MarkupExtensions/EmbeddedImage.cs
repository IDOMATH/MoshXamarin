using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [ContentProperty("ResourceId")]
    class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId))
                return null;

            return ImageSource.FromResource("HelloWorld.Images.gitrog.jpg");
        }
    }
}
