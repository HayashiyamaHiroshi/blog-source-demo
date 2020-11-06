import React, {FC} from 'react';
import {CommonProps, StudentType, TeacherType} from "../Types/TypeList";

const Student : FC<CommonProps<StudentType>> = (props) => {
    return (
        <div>
            <h2>生徒コンポーネント</h2>
            <p>名前：{props.Data.Name}</p>
            <p>学年：{props.Data.Gakunen}</p>
        </div>
    );
};

export default Student;