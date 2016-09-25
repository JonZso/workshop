class REPLACESTRING
  input = 'Hello£$%my£32$!name&*%is$Jon3!£$and£^*I242!barely^*(made%\"$!;it'
  puts input.gsub(/[^a-z ]/i, ' ').squeeze(' ') #Remove Spam from string
end