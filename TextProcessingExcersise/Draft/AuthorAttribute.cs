///<summary>
///  Draft
/// </summary>

namespace Draft
{
    /// <summary>
    ///  Specifies the autor of the code below
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class AuthorAttribute(string? inputName) : Attribute
    {
#pragma warning disable IDE0044
        //Holds the name of the author
        private string? name = inputName;
#pragma warning restore IDE0044 
    }
}
