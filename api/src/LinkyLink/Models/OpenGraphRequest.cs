using System.Diagnostics.CodeAnalysis;

namespace LinkyLink.Models
{
    /// <summary>
    /// This class is used to validate and request an open graph.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class OpenGraphRequest
    {
        public string Id { get; set; }
        public string Url { get; set; }
    }
}
