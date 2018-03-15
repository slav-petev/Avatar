namespace Avatar.Logic.Common.Extensions
{
    internal static class CommonExtensions
    {
        internal static string GetTypeName<T>(this T inputObject,
            string typeNameSuffix = null) => string.IsNullOrWhiteSpace(typeNameSuffix)
                ? inputObject.GetType().Name
                : inputObject.GetType().Name.Replace(typeNameSuffix, string.Empty);
    }
}
