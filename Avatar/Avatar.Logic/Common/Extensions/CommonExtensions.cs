namespace Avatar.Logic.Common.Extensions
{
    internal static class CommonExtensions
    {
        internal static string GetTypeName<T>(this T inputObject,
            string typeNameSuffix = null)
        {
            var typeName = inputObject.GetType().Name;
            if (string.IsNullOrWhiteSpace(typeNameSuffix)) return typeName;

            var typeNameWithoutSuffix = typeName.Replace(typeNameSuffix, 
                string.Empty);

            return $"{typeNameWithoutSuffix} {typeNameSuffix}";
        }
    }
}
