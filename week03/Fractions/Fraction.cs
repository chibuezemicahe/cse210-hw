using System;

public class Fraction {
   private int _numerator;
    private int _denominator;

    public Fraction(){
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNumber) {
        _numerator = wholeNumber;
        _denominator = 1;

    }
    
    public Fraction (int numerator, int denominator) {
        _numerator = numerator;
        _denominator = denominator;
    }


    public int GetTop(){
        return _numerator;
    }

    public int SetNumerator( int numerator) {
        _numerator = numerator;
        return _numerator;

    }

    public int GetDenominator(){
        return _denominator;
    }

    public int SetDenominator( int denominator) {
        _denominator = denominator;
        return _denominator;

    }

    public string GetFractionString() {
        return $"{_numerator}/{_denominator}";
    }

    public float GetDecimalValue() {
        return (float)_numerator / (float)_denominator;
    }
}