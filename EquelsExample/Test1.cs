namespace EquelsExample;

public class Test1
{
    public string Name { get; set; }

    public string Id { get; set; }

    public static bool operator ==(Test1 a, object b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(Test1 a, object b)
    {
        return !a.Equals(b);
        ;
    }

    public override bool Equals(object? test2)
    {
        try
        {
            bool isEquals = false;
            var firstElement = this;
            var secondElement = test2;
            var firstProperties = firstElement.GetType().GetProperties();
            var secondProperties = secondElement.GetType().GetProperties();
            foreach (var prop in secondProperties)
            {
                if (firstProperties?.FirstOrDefault(x => x.Name == prop.Name) == null)
                {
                    continue;
                }

                var temp = firstProperties?.FirstOrDefault(x => x.Name == prop.Name);
                if (temp != null)
                {
                    if (temp.GetValue(firstElement) == prop.GetValue(secondElement))
                    {
                        isEquals = true;
                    }
                    else
                    {
                        isEquals = false;
                        break;
                    }
                }
            }

            return isEquals;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}