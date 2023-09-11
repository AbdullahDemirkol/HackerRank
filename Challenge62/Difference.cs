

internal class Difference
{

    private int[] elements;
    public int maximumDifference;

    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    internal void ComputeDifference()
    {
        maximumDifference = 0;
        foreach (int firstElement in elements)
        {
            foreach (int secondElement in elements)
            {
                var difference = Math.Abs(firstElement - secondElement);
                if(difference>maximumDifference)
                    maximumDifference = difference;
                
            }
        }
        
    }
}