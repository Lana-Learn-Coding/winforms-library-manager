using System;

namespace LibraryApplication.Model
{
    public interface IIdentified
    {
        public int? Id { get; set; }
    }

    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }

        DateTime UpdatedAt { get; set; }
    }

    public interface INamed
    {
        string Name { get; set; }
    }
}