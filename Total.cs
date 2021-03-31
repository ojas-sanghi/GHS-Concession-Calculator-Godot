using Godot;

public class Total : Label
{
    public override void _Ready()
    {
        Events.costChanged += OnCostChanged;
    }

    void OnCostChanged() {
        double newPrice = 0;

        var listItems = GetTree().GetNodesInGroup("listItem");

        foreach (ListItem item in listItems) {
            double totalPrice = item.num * item.price;
            // string totalPrice = item.GetNode<Label>("TotalPrice").Text;
            // totalPrice = totalPrice.Substring(1); // cut off the $ sign
            // double price = double.Parse(totalPrice);
            newPrice += totalPrice;
        }

        Text = "Total: $" + newPrice.ToString();
    }
}
