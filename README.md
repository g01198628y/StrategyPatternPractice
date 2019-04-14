# StrategyPatternPractice
Ref: https://ithelp.ithome.com.tw/articles/10202506

## 策略模式 (Strategy Pattern)
定義一系列的演算法，並且把這些算法，用介面封裝到有公共介面的策略類中，使他們可以互相替換。

策略模式用策略的介面來替換某個實體中的方法，可以經由替換不同的策略使得物件擁有不同的行為。
經過策略的組合，我們得以獲得不同行為的物件。

**優點：**
* 靈活的替換不同的行為（演算法）
* 策略拓展容易
* 避免使用很多if else

**缺點：**
* 必須自行決定要使用哪種策略
* 可能產生很多策略類

可以將這些行為不同的物件用工廠模式封裝起來，解決使用這些模式時需要先事先知道有哪些策略，並且需要自行決定使用哪些策略的問題。
