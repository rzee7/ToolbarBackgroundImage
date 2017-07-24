# ToolbarBackgroundImage
Set Background Image in Toolbar/NavigationBar.

Just do the following:
##Android:

1. Copy image in `Layout > Drawable > yourImage `.
2. Add this line in `toolbar.xml`:
 `android:background="@drawable/yourImage"`
 
 If you want subtilte then copy `NavbarRenderer.cs` else no need to have in solution.
 
 ##iOS
 
1. Copy image in `Resource > yourImage `.
2. Add this line in `AppDelegate.cs`:
 `UINavigationBar.Appearance.BarTintColor = UIColor.FromPatternImage(UIImage.FromFile("yourImage.png"))`
 
 
 Result:
 

