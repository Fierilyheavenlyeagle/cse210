public class Fraction
{
  private int _numerator;
  private int _denominator;

  public Fraction()
  {
    _numerator = 1;
    _denominator = 1;
  }
  public Fraction(string numerator)
  {
    _numerator = int.Parse(numerator);
    _denominator = 1;
  }
  public Fraction(string numerator, string denominator)
  {
    _numerator = int.Parse(numerator);
    _denominator = int.Parse(denominator);
  }

  public int GetNumerator()
  {
    return _numerator;
  }
  public void SetNumerator( int numerator)
  {
    _numerator = numerator;
  }
  public int GetDenominator()
  {
    return _denominator;
  }
  public void SetDenominator(int denominator)
  {
    _denominator = denominator;
  }

  public string GetFractionString()
  {
    return $"The fraction:{GetNumerator()}/{GetDenominator()}"; 
  }
  public string GetDecimal()
  {
    double result = (double)GetNumerator()/GetDenominator();
    return $"Decimal: {result}";
     
  }

}