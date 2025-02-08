

class Fraction {
    private int _top;
    private int _bottom;

    public Fraction(int numerator, int denominator) {
        this._top = numerator;
        this._bottom = denominator;
    }

    public Fraction(int _top) {
        this._top = _top > 5 ? 5 : _top;
        this._bottom = 1;
    }

    public Fraction() {
        this._top = 1;
        this._bottom = 1;
    }

    public int get_top() {
        return this._top;
    }

    public int getDenominator() {
        return this._bottom;
    }

    public void set_top(int _top) {
        this._top = _top;
    }

    public void set_bottom(int _bottom) {
        this._bottom = _bottom;
    }

    public void setFraction(int _top, int _bottom) {
        this._top = _top;
        this._bottom = _bottom;
    }

    public void setFraction(int _top) {
        this._top = _top;
        this._bottom = 1;
    }

    public void setFraction() {
        this._top = 0;
        this._bottom = 1;
    }

    public void add(Fraction f) {
        this._top = this._top * f._bottom + f._top * this._bottom;
        this._bottom = this._bottom * f._bottom;
    }

    public void substract(Fraction f) {
        this._top = this._top * f._bottom - f._top * this._bottom;
        this._bottom = this._bottom * f._bottom;
    }

    public void multiply(Fraction f) {
        this._top = this._top * f._top;
        this._bottom = this._bottom * f._bottom;
    }

    public void divide(Fraction f) {
        this._top = this._top * f._bottom;
        this._bottom = this._bottom * f._top;
    }

    public void simplify() {
        int gcd = gcd(this._top, this._bottom);
        this._top = this._top / gcd;
        this._bottom = this._bottom / gcd;
    }

    private int gcd(int a, int b) {
        if (b == 0) {
            return a;
        }
        return gcd(b, a % b);
    }

    public String toString() {
        return this._top + "/" + this._bottom;
    }
    
}