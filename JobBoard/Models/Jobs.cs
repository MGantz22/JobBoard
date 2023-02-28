using System.Collections.Generic;

namespace JobBoard.Models
{
  class Jobs
  {
    public string Description { get; set; }
    private static List<Jobs> _instances = new List<Jobs> {};

    public Jobs(string description)
    {
      Description = description;
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