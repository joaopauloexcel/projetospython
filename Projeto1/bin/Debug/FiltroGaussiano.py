import cv2
import sys

original = cv2.imread("imgOriginal.jpg")
dim = (619, 512)
original  = cv2.resize(original, dim)
gaussiano = cv2.GaussianBlur(original,(7,7),5)
cv2.imwrite("gaussiano.jpg", gaussiano)
sys.exit()

