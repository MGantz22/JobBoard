using System.Collections.Generic;

namespace JobBoard.Models
{
  class Jobs
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Contact { get; set; }
    private static List<Jobs> _instances = new List<Jobs> {};

    public Jobs(string title, string description, string contact)
    {
      Title = title;
      Description = description;
      Contact = contact;
      _instances.Add(this);
    }

    public static List<Jobs> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}