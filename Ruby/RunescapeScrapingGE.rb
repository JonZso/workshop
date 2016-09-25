require 'HTTParty'
require 'Nokogiri'

#To check item. get it's name and price. and see if it has risen. site is live so results vary.

page = HTTParty.get('http://services.runescape.com/m=itemdb_rs/Dragon_claw/viewitem?obj=14484') #Item Risen

parse_page = Nokogiri.HTML(page) #html

itemName = parse_page.at_css('#grandexchange > div.stickyWrap > div.contents > main > div.content.roughTop > div.item-description > h2').text
itemPrice = parse_page.at_css('#grandexchange > div.stickyWrap > div.contents > main > div.content.roughTop > div.stats > h3 > span').text
_RawitemChange = parse_page.at_css('#grandexchange > div.stickyWrap > div.contents > main > div.content.roughTop > div.stats > ul > li:nth-child(1) > span').text
itemChangeText = ''

itemChange = _RawitemChange.split(' ')


if itemChange.include? "0"
  itemChangeText ='There has been no current change.'
elsif itemChange.include? "-"
  itemChangeText ="The Item has decreased by #{itemChange[0]}#{itemChange[1]}"
else
  itemChangeText = "The Item has increased by #{itemChange[0]}"


end

puts 'The Item is: %s
It is currently: %s.
%s' % [itemName, itemPrice, itemChangeText]