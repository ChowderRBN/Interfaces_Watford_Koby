using System;                           // Gives access to base types
using System.Collections.Generic;       // Useful for collections (not used here)
using System.Text;                      // Not used here, but could help with string formatting

namespace Interfaces_Watford_Koby       // Namespace for organization
{
    internal interface IGenre           // Interface that both Game and Movie must implement
    {
        // Property signatures that must be implemented in classes
        public string Esrb { get; set; }    // ESRB rating
        public string Genre { get; set; }   // Genre of the media
        public string Title { get; set; }   // Title of the media

        // Method signature to describe the object (must be defined in implementing classes)
        public string Describe();           // Describes the media content
    }
}
