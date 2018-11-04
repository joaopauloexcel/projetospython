import cv2

imgOrigem = cv2.imread("imgOriginal.jpg")
imgSub = cv2.imread("sub.jpg")
dim = (619, 512)
imgOrigem = cv2.resize(imgOrigem, dim)
imagemResult = cv2.add(imgOrigem, imgSub)
cv2.imwrite("adicao.jpg", imagemResult)