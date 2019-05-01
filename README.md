# ASP_NET_MVC_Q6

## Routing

### 基本

1. 修改專案，定義以下的 Routing 規則，當瀏覽器輸入該網址顯示對應的 Controller, Action, 參數

    - /Login => controller = Default, action = Login
    - /Home/Welcome => controller = Home, action = Welcome
    - /Contact => controller = Home, action = ContactMe
    - /List => controller = Default, action = List


2. 建立以下 Area 與 Routing 規則，當瀏覽器輸入該網址顯示對應的 Area, Controll, Action, 參數

    - /Order/List/{page} => area = Order, controller = Default, action = List, {page} = 數字
    - /OrderDetail/{id} => area = Order, controller = Default, action = Detail, {id} = 數字
    - /Ticket/List => area = Ticket, controller = Main, action = List
    - /Ticket/Detail/{id} => area = Ticket, controller = Main, action = Detail, {id} = 數字
    - /Product/{category} => area = Product, controller = Main, action = List, {category} = 字串


### 進階

- 使用 ActionFilter ，處理 Routing Data 的顯示