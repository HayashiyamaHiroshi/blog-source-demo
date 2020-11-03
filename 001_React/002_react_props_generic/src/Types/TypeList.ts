export type StudentType = {
    Name : string,
    Gakunen : number
}

export type TeacherType = {
    Name : string,
    Kyouka : string
}

export type CommonProps<T> = {
    Data : T
}