import cv2

imgOriginal = cv2.imread("imgOriginal.jpg")
imgGaussiano = cv2.imread("gaussiano.jpg")
dim = (619, 512)
imgOriginal  = cv2.resize(imgOriginal, dim)
NovaImagem = cv2.subtract(imgOriginal, imgGaussiano)
cv2.imwrite("sub.jpg", NovaImagem)


