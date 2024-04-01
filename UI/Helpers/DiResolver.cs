using Microsoft.Extensions.DependencyInjection;
using System.Windows.Markup;

namespace UI.Helpers
{
    public class DiResolver : MarkupExtension
    {
        static IServiceProvider? _container;

        public Type? Type { get; set; }

        public static void SetContainer(IServiceProvider container)
        {
            _container = container;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            Validate();
            return _container!.GetRequiredService(Type!);
        }

        void Validate()
        {
            ValidateContainer();
            ValidateType();
        }

        void ValidateType()
        {
            if (Type == null)
            {
                throw new DiMarkupExtensionException($"Type is null.");
            }
        }

        static void ValidateContainer()
        {
            if (_container == null)
            {
                throw new DiMarkupExtensionException($"Container is null. Please call {nameof(SetContainer)}");
            }
        }
    }

    public class DiMarkupExtensionException(string message) : Exception(message)
    {
    }
}
