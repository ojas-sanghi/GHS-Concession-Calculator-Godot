using Godot;

public class ItemSpinBox : HBoxContainer
{
    SpinBox spinBox;
    ListItem parent;

    public override void _Ready()
    {
        spinBox = (SpinBox)FindNode("SpinBox");
        parent = (ListItem)GetParent();
    }

    void OnMinusPressed() {
        spinBox.Value--;
        parent.OnCostChanged(spinBox.Value);
        Events.publishCostChanged();
    }

    void OnPlusPressed() {
        spinBox.Value++;
        parent.OnCostChanged(spinBox.Value);
        Events.publishCostChanged();
    }
}
