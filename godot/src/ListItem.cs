using Godot;
using System;

public class ListItem : HBoxContainer
{
    [Export] string itemName = "";
    [Export] public double price = 1.0;

    public int num = 0;

    ItemSpinBox itemSpinBox;
    RichTextLabel nameAndPrice;
    Label totalPrice;

    public override void _Ready()
    {
        nameAndPrice = GetNode<RichTextLabel>("NameAndPrice");
        totalPrice = GetNode<Label>("TotalPrice");

        // set label in ItemInfoButton to exported name
        // label.Text = itemName;
        // Label label = (Label) (GetNode<ItemSpinBox>("ItemInfoButton").FindNode("Label"));

        // nameAndPrice.Text = itemName + "\n" + "Cost: $" + price.ToString();
        nameAndPrice.BbcodeText = "[center]" + itemName + "\n [b]Cost: $" + price.ToString() + "[/b][/center]";
        // [center] Generic Item [b]Cost: $3[/b] [/center]

        // prorataPrice.Text = "$" + price.ToString();
    }

    public void OnCostChanged(double newNum) {
        num = (int)newNum;
        totalPrice.Text = "Total: $" + (num * price).ToString();
    }
}
