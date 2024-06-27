using System;
using System.Collections.Generic;

public class Deque
{
    private LinkedList<int> items = new LinkedList<int>();

    public void AddFront(int item)
    {
        items.AddFirst(item);
    }

    public void AddBack(int item)
    {
        items.AddLast(item);
    }

    public void RemoveFront()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Дек пуст, невозможно удалить элемент спереди.");
        }
        items.RemoveFirst();
    }

    public void RemoveBack()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Дек пуст, невозможно удалить элемент сзади.");
        }
        items.RemoveLast();
    }

    public override string ToString()
    {
        return string.Join(", ", items);
    }
}
