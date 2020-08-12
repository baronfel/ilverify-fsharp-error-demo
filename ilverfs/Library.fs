module ilverfs

let relative (segment: string) = segment.TrimStart [| '/' |]