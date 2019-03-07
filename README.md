# otsu_method
otsu演算法實作
Otsu Method

The purpose of Otsu method is to let an image to become binary image using adaptive threshold.
Otsu method is a statistic method that find a threshold to divide the Dark part and Light part. Because Chinese calligraphy character written in black ink normally, so it’s a good way to use Otsu method to extract character part in this case.
The concept of Otsu method explains below:
First of all, we need to find the partition of gray value appear in the image:
P(i )=n_i/(W×H)
W denotes the weight of the image, H denotes the Height of the image.
Second, we need to define the set of partition of Dark part and Light part :
W_D=P( D )=∑_(i=0)^(n_i) P( i )
W_L=P(L)=∑_(i=T_(h+1))^255 P(i )
After determine W_D and W_L, we can compute the mean of W_D and W_L like below:
U_D=∑_(i=0)^Th  (P(i ))/W_D ×i

U_L=∑_(i=T_(h+1))^255  (P(i))/W_L ×i
U_Ddenotes to W_D’s mean and U_L denotes to W_L’s mean.
Then, we can compute the deviation of W_D and W_L like the function below:
σ_D^2=∑_(i=0)^(T_h)(i-U_D)(P(i))/〖W_ 〗_D 
σ_L^2=∑_(i=Th+1)^255(i-U_L)(P(i ))/W_L 
And our goal is to find a maximum deviation within D and L, and find a minimum deviation within D and a minimum deviation within L. 
Verified by mathematics, if we found a maximum deviation within D and L, on the other hand means we found the minimum deviation within D and a minimum deviation within L. Therefore, we can just focus on finding a maximum deviation within D and L. And the function defined below:
σ_W^2=W_L 〖 σ〗_L^2+W_D 〖 σ〗_D^2
