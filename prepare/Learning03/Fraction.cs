

class Fraction {
    private int _top;
    private int _bottom;

    public Fraction(int numerator, int denominator) {
        _top = numerator;
        _bottom = denominator;
    }

    public Fraction(int _top) {
        this._top = _top > 5 ? 5 : _top;
        this._bottom = 1;
    }

    public Fraction() {
        this._top = 1;
        this._bottom = 1;
    }

    private int getTop() {
        return this._top;
    }

    private int getBottom() {
        return this._bottom;
    }

    private void setTop(int top) {
        if(int.IsNegative(top)) {
            throw new ArgumentException("Top cannot be negative");
        }
        this._top = top;
    }

    private void setBottom(int bottom) {
        this._bottom = bottom;
    }

    public void publicar(){
        Console.WriteLine("Top: " + this.getTop());
    }
}