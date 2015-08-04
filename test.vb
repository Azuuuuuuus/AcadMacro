Sub test()

'Dim circleObj As AcadCircle
 ' Dim center(0 To 2) As Double
  'Dim radius As Double
  'center(0) = 2#: center(1) = 2#: center(2) = 0#
  'radius = 0.5
  'Set circleObj = ThisDrawing.ModelSpace.AddCircle(center, radius)
  ZoomAll
  Dim point1(2) As Double
point1(0) = 77.2271: point1(1) = 63.5293: point1(2) = 0#
radius = Sqr(point1(0) ^ 2 + point1(1) ^ 2)
'THX Hydrangea!
MsgBox ("Radius=" & radius)


End Sub
