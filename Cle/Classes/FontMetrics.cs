namespace Cle.Classes
{
  public abstract class FontMetrics
  {
    public virtual int Ascent => 0;

    public virtual int AverageCharacterWidth => 0;

    public virtual int Descent => 0;

    public virtual int DigitizedAspectX => 0;

    public virtual int DigitizedAspectY => 0;

    public virtual int ExternalLeading => 0;

    public virtual int Height => 0;

    public virtual int InternalLeading => 0;

    public virtual int MaximumCharacterWidth => 0;

    public virtual int Overhang => 0;

    public virtual int Weight => 0;
  }
}