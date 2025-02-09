

class Fraction {
    private int _top;
    private int _bottom;

    public Fraction(int numerator, int denominator) {
        setTop(numerator);
        setBottom(denominator);
        //this._top = numerator;
        //this._bottom = denominator;
    }

    public Fraction(int top) {
        setTop(top);
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
        this._top = top >= 5 ? 5 : top;
    }

    private void setBottom(int bottom) {
        if(int.IsNegative(bottom)) {
            throw new ArgumentException("Top cannot be negative");
        }
        this._bottom = bottom;
    }

    public void publicar(){
        Console.WriteLine("Top: " + this.getTop());
    }

    public string getFractionString() {
        return this.getTop() + "/" + this.getBottom();
    }

    public double getDecimalValue() {
        return (double)this.getTop() / this.getBottom();
    }
}