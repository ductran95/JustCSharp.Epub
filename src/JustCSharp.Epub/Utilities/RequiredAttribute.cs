using System;

namespace JustCSharp.Epub.Utilities
{
    /// <summary>
    /// Required Attribute
    /// to mark a field or property is required
    /// when validating before serialization
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class RequiredAttribute: Attribute
    {
        public bool NotEmpty { get; set; }

        public RequiredAttribute(bool notEmpty = false)
        {
            NotEmpty = notEmpty;
        }
    }
}