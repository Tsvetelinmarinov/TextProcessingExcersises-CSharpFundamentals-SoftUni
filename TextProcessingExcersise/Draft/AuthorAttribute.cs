///<summary>
///  Author attribute
/// </summary>

using System;

namespace Reflect
{
    /// <summary>
    ///   Specifies the autor of the code below
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class AuthorAttribute(string name) : Attribute 
    {
        //holds the name of the authos local
        private static string? _name;

        /// <summary>
        ///  Set the name of the author
        /// </summary>
        public string? Name
        {
            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(name);
                _name = name;
            }
        }       
    }
}
