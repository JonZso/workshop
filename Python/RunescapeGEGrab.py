import requests as WebsiteTarget
import bs4
import re
import ctypes
import easygui

### Created to check Runescape items and show their prices.

##Red Santa, H'ween
SantaHatPrice = WebsiteTarget.get("http://services.runescape.com/m=itemdb_rs/Santa_hat/viewitem?obj=1050")
RedHweenPrice = WebsiteTarget.get("http://services.runescape.com/m=itemdb_rs/Red_h'ween_mask/viewitem?obj=1057")

Santa = bs4.BeautifulSoup(SantaHatPrice.text, "html.parser")
Rween = bs4.BeautifulSoup(RedHweenPrice.text, "html.parser")

SantaPrice = Santa.select(
    '#grandexchange > div.stickyWrap > div.contents > main > div.content.roughTop > div.stats > h3 > span')
RweenPrice = Rween.select(
    '#grandexchange > div.stickyWrap > div.contents > main > div.content.roughTop > div.stats > h3 > span')

SantaHat = SantaPrice[0].text
RedWeen = RweenPrice[0].text




easygui.msgbox("Red Santa Hat is : " + SantaHat + "\nRed H'ween is: " + RedWeen, title="Current Grand Exchange Prices")
