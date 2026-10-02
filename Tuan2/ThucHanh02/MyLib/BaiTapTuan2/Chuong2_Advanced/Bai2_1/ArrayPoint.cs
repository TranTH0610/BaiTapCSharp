using System;
using System.Collections;
public class ArrayPoint
{
    private ArrayList dsPoint;
    public ArrayPoint()
    {
        dsPoint = new ArrayList();
    }
       // Indexer
    public Point this[int i]
    {
        get
        {
            return (Point)dsPoint[i]!;
        }
        set
        {
            dsPoint[i] = value;
        }
    }
    public void ADD(Point p)
    {
        dsPoint.Add(p);
    }
    public int Count
    {
        get
        {
            return dsPoint.Count;
        }
    }

}