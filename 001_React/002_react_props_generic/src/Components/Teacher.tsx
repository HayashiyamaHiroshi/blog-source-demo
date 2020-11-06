import React, {FC} from 'react';
import {CommonProps, TeacherType} from "../Types/TypeList";

const Teacher : FC<CommonProps<TeacherType>> = (props) => {
    return (
        <div>
            <h2>先生コンポーネント</h2>
            <p>名前：{props.Data.Name}</p>
            <p>教える教科：{props.Data.Kyouka}</p>
        </div>
    );
};

export default Teacher;