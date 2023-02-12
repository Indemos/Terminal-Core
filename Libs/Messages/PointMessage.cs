using System;
using Terminal.Core.EnumSpace;

namespace Terminal.Core.MessageSpace
{
  public struct PointMessage
  {
    /// <summary>
    /// Symbol
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// End date
    /// </summary>
    public DateTime? MinDate { get; set; }

    /// <summary>
    /// Start date
    /// </summary>
    public DateTime? MaxDate { get; set; }

    /// <summary>
    /// Resolution
    /// </summary>
    public ResolutionEnum? Resolution { get; set; }
  }
}
