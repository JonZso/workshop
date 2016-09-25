# This simple bot responds to every "Ping!" message with a "Pong!"
#TODO: Could Add error-checking IF people try to join a course when they're already in one.


require 'discordrb'

bot = Discordrb::Commands::CommandBot.new token: '_TAKEN TOKEN OUT. PUT TOKEN HERE_ ', application_id: _PUT ID HERE_, prefix: "!"
# bot = Discordrb::Bot.new token: #Original One...



# Here we output the invite URL to the console so the bot account can be invited to the channel. This only has to be
# done once, afterwards, you can remove this part if you want
puts "This bot's invite URL is #{bot.invite_url}."
puts 'Click on it to invite it to your server.'


bot.message(with_text: '!list') do |event|
 event.user.pm("""
 Don't know what to do? ask something and end the sentence with ?todo?

 Don't know what type of work todo? type \"** ?work? **\" and i'll pick something for you to work on.

 Type \"**?code?**\" and i'll pick a language at random for you to learn.

 **Can't Decide on what take-away to get? End sentence with ?eat? '_What should i ?eat?_'
 _(Chinese, Indian, Thai, Mexican, Chicken, Sushi, Pizza, Italian..)_

Want me to answer something? start your sentence with ?should

want srs answer? just say '?srsnow'

if you laugh, i'll laugh _probably_




  """)
end





# bot.message(contains: /bot|people|robot/) { |e| e.respond 'hehe :baby:
# I\'m a human' }


bot.message(contains: /Runscape|RS|runescape/) {
 |e| 
 e.respond 'omg! I love runescape!'
  }


bot.message(with_text: '?me') do |event|
  bot.game="With #{event.user.name}.."
end


bot.message(with_text: '!rs') do |event|
  bot.game="Runescape"
end

bot.message(start_with: '?srsnow') do |event|
  srs_list = ['er.. yes!','uhm.. no']
  event.respond(srs_list.sample)
end


bot.message(start_with: '?food?') do |event|
  food_list = ['Chinese','Indian','Thai','Mexican','Chicken','Sushi','Pizza', 'Italian','Haven\'t you ate enough?']
  event.respond(food_list.sample)
end


bot.message(start_with: '?should') do |event|
  k =event.respond ('Let me think...Uhm..')
  sleep(1.5)
  opinionlist= ["#{event.user.name}, Yes you should.",
    'No','Maybe','Ask Again later','Maybe you should be asking yourself...','I have no idea, I\'m only a robot.','Don\'t ask me',
    'I\'m just a baby...
    Goo-Goo Ga-Ga','Yes without a doubt!',
    'well..I think so',
    'You shouldn\'t need to ask..']
    k.edit(opinionlist.sample)
end
# bot.message(with_text: '?rs') do |event|
#   listname =['']
#   event.respond(listname.sample)


bot.message(end_with: '?rs') do |event|
  stuff_todo =['Slayer','A Quest?',
    'maybe you should try some PVM',
    'If I was allowed to play runescape I\'d probably do some fishing',
    'How about some Dungeoneering?',
    'Why not train invention?',
    'Socialise? Maybe say hello in clan?',
    'Why not recruit for clan? that _might_ be fun',
    'If I had a life I\'d probably do some slayer stuff?',
    'Goo-Goo Ga-Ga',
    'I\'m just a baby...']
  event.respond(stuff_todo.sample)
 end


bot.message(end_with: '?todo?') do |event|
  to_do_list = ['Work? \n Got no work? Reply: "?work?"', 
    'Play Games',
     'Sleep',
     'Draw something? Be creative.', 
     'Surf web',
     'Waste time _like always_',
      'I don\'t know.. Maybe be productive?',
      'Maybe you shouldn\'t rely on me and make up your own mind... _pathetic_ ',
    'Work? \n Got no work? Reply: "!work?"']
  event.respond(to_do_list.sample)
end

bot.message(with_text: '?work?') do |event|
  work_list = ['Learn a programming language?\n Reply with "?code?" and I\'ll randomly Select one...',
    'Do a programming challenge?',
    'Touch up something you\'ve finished and make it better',
    'Do something you could put on your CV?',
    'Look at some open source stuff and try participate?',
    'Lurk Stack Overflow and help peoples enquiries?',
    'Maybe your attitude?',
    'If I were you i\'d work on dank memes']
  event.respond(work_list.sample)
end

bot.message(with_text: '?code?') do |event|
  code_list = ['Java',
    'Ruby','Rails','HTML','CSS', 'JavaScript','Python','C#','C++','Rust','F#','MySQL','PHP','node.JS','Android']
  event.respond(code_list.sample)
end


bot.command(:pst) do |event, u|
  user = event.bot.parse_mention(u)
  event.user.pm('Psst! Hello!')
end


 # bot.message(end_with: 'lol?') do |event|
 #  lol_list =['Yeah, that is pretty funny','I\'m not laughing _awkwards_','Haha!','Good One!','LOL!','Omg I can\'t believe you\'ve just said that!','I don\'t get it...']
 #  event.respond(lol_list.sample)
 # end



 bot.message(contains: /lol|LOL|lmao|rofl|haha|hehe/) do |event|
  lol_list =['that is pretty funny',
    '',
    'I\'m not laughing _awkwards_',
    'Haha!',
    "Good One! #{event.user.name}",
    'LOL! :joy: ',
    'Omg I can\'t believe you\'ve just said that!',
    'I don\'t get it...',
    'That\'s kinda offensive...',
    '',
    '...',
    '_*tumbleweed*_',
    "#{event.user.name}, you make me laugh.", 
    "#{event.user.name}, You're hilarious"]
  event.respond(lol_list.sample)
 end

bot.message(contains: /fuck|shit|twat|ffs|piss|omfg|cunt|bastard|prick/) do |event|
         naughty_list = ["Err.. should you really be using words like that #{event.user.mention}","Look everyone #{event.user.mention} thinks they're tough!",]
         event.respond(naughty_list.sample)
         event.user.pm("Hey!
You shouldn't be swearing #{event.user.name}...")
 end


bot.message(contains: /bnice/) do |event|
  creepy_list = ["Wow! #{event.user.name} You look nice today!",
    "You are so smart!",
    "Have you lost weight?",
    "You're the coolest #{event.user.name}",
    "You're my favourite user on this server",
    "Why can't more people be like you",
    """#{event.user.name}, I Wrote you a poem...
Drums go \'Bang!\'
Trumpets go \'Toot\'
_*Mumbles*_
You're cute!
""",
"""You should get yourself a little snack and a nice cold drink,
If I could. #{event.user.name} I\'d get you it all!"""]
  event.respond(creepy_list.sample)
end



##CREEPT MESSAGE

 # bot.message(contains: /that|this|he|ye|no/) do |event|
 #  sad_list =['_Mummy?_',
 #    '',
 #    '',
 #    '_I feel sleepy..._',
 #    '_Im Scared..._',
 #    '_Please talk to me..._',
 #    "_I wish #{event.user.nickname}_ would talk to me again..",
 #    'I\'m scared of the dark']
 #    sleep(120)
 #    event.respond(sad_list.sample)
 #  end

bot.run






